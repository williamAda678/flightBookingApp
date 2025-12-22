import { useCallback, useState } from "react";
import { Flight, SearchFlight } from "../types/types";
import { fetchSerachFlight } from "./api";

export function useFlightSearch() {
  const [flights, setFlights] = useState<Flight[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  const search = useCallback((params: SearchFlight) => {
    let mounted = true;
    console.log("12");
    (async () => {
      try {
        const data = await fetchSerachFlight(params);
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

  return { flights, loading, error, search };
}
