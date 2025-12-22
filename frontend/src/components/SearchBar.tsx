import { Box, TextField } from "@mui/material";
import React, { useCallback, useEffect, useState } from "react";
import { fetchSerachFlight } from "../services/api";
import { Flight, SearchFlight } from "../types/types";
import { useFlightSearch } from "../services/useFlightSearch";

export default function FlightsList() {
  const { flights, loading, error, search } = useFlightSearch();
  const [formData, setFormData] = useState<SearchFlight>({
    origin: "",
    destination: "",
    departureDate: "",
    cabinClass: "",
  });

  const handleChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLSelectElement>
  ) => {
    const { name, value } = e.currentTarget;
    setFormData((prev) => ({ ...prev, [name]: value }));
  };

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    search(formData);
  };

  return (
    <>
      <form onSubmit={handleSubmit}>
        <input
          type="text"
          name="origin"
          placeholder="from"
          value={formData.origin}
          onChange={handleChange}
        />
        <input
          type="text"
          name="destination"
          placeholder="from"
          value={formData.destination}
          onChange={handleChange}
        />
        <input
          type="date"
          name="departureDate"
          value={formData.departureDate}
          onChange={handleChange}
        />
        <select
          name="cabinClass"
          value={formData.cabinClass}
          onChange={handleChange}
        >
          <option value="">Any Class</option>
          <option value="economy">Economy</option>
          <option value="business">Business</option>
          <option value="first">First</option>
        </select>
        <button type="submit">Search</button>
      </form>

      {loading && <p>Searching...</p>}
      {error && <p style={{ color: "red" }}>{error}</p>}

      {flights.length > 0 && (
        <table className="table">
          <thead>
            <tr>
              <th>Airline</th>
              <th>From</th>
              <th>To</th>
              <th>Departure</th>
              <th>Price</th>
            </tr>
          </thead>
          <tbody>
            {flights.map((f) => (
              <tr key={f.flightId}>
                <td>{f.airline}</td>
                <td>{f.origin}</td>
                <td>{f.destination}</td>
                <td>{new Date(f.departureTime).toLocaleString()}</td>
                <td>${f.price.toFixed(2)}</td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </>
  );
}
