// FlightDetails.tsx
import { useParams, Link } from "react-router-dom";
import { useState, useEffect } from "react";
import { Flight } from "../../types/types";
import { fetchFlightById } from "../../services/api";

export default function FlightDetails() {
  const { flightId } = useParams<{ flightId: string }>();
  const [flight, setFlight] = useState<Flight | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    async function loadFlight() {
      try {
        setLoading(true);
        setError(null);
        console.log(flightId);
        if (!flightId) throw new Error("No flight ID");

        const id = Number(flightId);
        console.log(id);
        if (isNaN(id)) throw new Error("Invalid flight ID");

        const data = await fetchFlightById(id); // Replace with your API
     
        
        setFlight(data);
      } catch (err: any) {
        setError(err.message);
      } finally {
        setLoading(false);
      }
    }

    loadFlight();
  }, [flightId]);

  if (loading) return <p>Loading flight...</p>;
  if (error) return <p style={{ color: "red" }}>{error}</p>;
  if (!flight) return <p>Flight not found</p>;

  return (
    <div>
      <h2>{flight.airline}</h2>
      <p>
        {flight.origin} → {flight.destination}
      </p>
      <p>Departure: {new Date(flight.departureTime).toLocaleString()}</p>
      <p>Price: ${flight.price.toFixed(2)}</p>
      <Link to="/">Back to results</Link>
    </div>
  );
}
