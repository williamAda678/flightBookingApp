// FlightsList.tsx
import { useEffect, useState } from "react";
import { Airport, Flight, SearchFlight } from "../types/types";
import { useFlightSearch } from "../services/useFlightSearch";
import { FlightsList } from "../pages/flightsPage/FlightsList";
import Box from "@mui/material/Box";
import { Autocomplete, Button, MenuItem, TextField } from "@mui/material";
import React from "react";
import { fetchAirports, fetchFlights } from "../services/api";

export default function SearchBar() {
  const [airports, setAirports] = useState<Airport[] | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

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
    //search(formData);
  };

  useEffect(() => {
    async function loadFlight() {
      try {
        setLoading(true);
        setError(null);

        const data = await fetchAirports();

        setAirports(data);
      } catch (err: any) {
        setError(err.message);
      } finally {
        setLoading(false);
      }
    }

    loadFlight();
  }, []);
  if (loading) return <p>Loading flight...</p>;
  if (error) return <p style={{ color: "red" }}>{error}</p>;
  if (!airports) return <p>airports not found</p>;

  return (
    <>
      <Box
        component="form"
        sx={{ "& .MuiTextField-root": { m: 1, width: "25ch" } }}
        noValidate
        autoComplete="on"
      >
        <Autocomplete
          id="Search-origin"
          disableClearable
          options={airports?.map((airports) => airports.airport)}
          renderInput={(params) => <TextField {...params} label="origin" />}
        />
        <Autocomplete
          id="Search-destination"
          disableClearable
          options={airports.map((airports) => airports.airport)}
          renderInput={(params) => (
            <TextField {...params} label="destination" />
          )}
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
        <Button variant="contained">Search</Button>
      </Box>
    </>
  );
}
