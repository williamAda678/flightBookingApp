import { useCallback, useState } from "react";
import { Flight, SearchFlight } from "../types/types";
import { fetchFlights, fetchSerachFlight } from "./api";

export async function useGetFlight() {
  const [flights, setFlights] = useState<Flight[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  const flightList = useCallback(() => {
    let mounted = true;
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
  return { flights, loading, error, flightList };
}
