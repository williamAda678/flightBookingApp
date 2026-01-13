import { Link } from "react-router-dom";
import { Flight } from "../../types/types";

type FlightsListProps = {
  flights: Flight[];
};

export function FlightsList({ flights }: FlightsListProps) {
  if (!flights.length) return <p>No flights found</p>;

  return (
    <table className="table">
      <thead>
        <tr>
          <th>Airline</th>
          <th>From</th>
          <th>To</th>
          <th>Departure</th>
          <th>Price</th>
          <th>Book</th>
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
            <td>
              <Link to={`/flight/details/${f.flightId}`}>View details</Link>
            </td>
          </tr>
        ))}
      </tbody>
    </table>
  );
}
