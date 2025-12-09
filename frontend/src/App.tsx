import React from "react";
import FlightsList from "./components/FlightsList";

export default function App() {
  return (
    <div className="app-container">
      <header>
        <h1>Flight Booking App</h1>
      </header>
      <main>
        <FlightsList />
      </main>
    </div>
  );
}
