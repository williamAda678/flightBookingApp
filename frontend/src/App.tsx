import React from "react";
import FlightsList from "./components/FlightsList";
import SearchBar from "./components/SearchBar";

export default function App() {
  return (
    <div className="app-container">
      <header>
        <h1>Flight Booking App</h1>
      </header>
      <main>
        <SearchBar />
      </main>
    </div>
  );
}
