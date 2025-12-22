import React, { useEffect, useState } from "react";
import { Flight } from "../types/types";
import { fetchFlights } from "../services/api";

export default function FlightsList() {
  const [flights, setFlights] = useState<Flight[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
 
    let mounted = true;
    console.log("12");
    (async () => {
      try {
        const data = await fetchFlights();
        if (mounted) setFlights(data);
      } catch (err) {
        if (mounted) setError(String(err));
      } finally {
        if (mounted) setLoading(false);
      }
    })();
    return () => {
      mounted = false;
    };
  }, []);

  if (loading) return <p>Loading flights...</p>;
  if (error) return <p style={{ color: "red" }}>{error}</p>;

  return (
    <div>
      <h2>Available Flights</h2>
      {flights.length === 0 ? (
        <p>No flights available.</p>
      ) : (
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
                <td>{f.price.toFixed(2)}</td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
}
