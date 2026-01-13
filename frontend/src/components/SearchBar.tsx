// FlightsList.tsx
import { useState } from "react";
import { SearchFlight } from "../types/types";
import { useFlightSearch } from "../services/useFlightSearch";
import { FlightsList } from "../pages/flightsPage/FlightsList";

export default function SearchBar() {
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
          placeholder="From"
          value={formData.origin}
          onChange={handleChange}
        />
        <input
          type="text"
          name="destination"
          placeholder="To"
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
    </>
  );
}
