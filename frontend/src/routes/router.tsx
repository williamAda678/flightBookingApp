import { createBrowserRouter } from "react-router-dom";
import App from "../App";
import FilghtDetails from "../pages/flightsPage/FlightDetail";
import HomePage from "../pages/homePage/HomePage";

export const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    children: [
      {
        path: "/",
        element: <HomePage />,
      },
      { path: "/flight/details/:flightId", element: <FilghtDetails /> },
    ],
  },
]);
