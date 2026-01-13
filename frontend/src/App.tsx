import React from "react";
import SearchBar from "./components/SearchBar";
import { Container } from "@mui/material";
import { Outlet } from "react-router-dom";

export default function App() {
  return (
    <div className="app-container">
      <header>
        <h1>Flight Booking App</h1>
      </header>
      <Container maxWidth="xl" sx={{ mt: 8 }}>
        <Outlet />
      </Container>
    </div>
  );
}
