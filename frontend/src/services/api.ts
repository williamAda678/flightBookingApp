import { json } from "node:stream/consumers";
import { API_BASE } from "../constants/config";
import { Flight, SearchFlight } from "../types/types";

const BaseApi = API_BASE;

async function fetchApi(path: string, init?: RequestInit) {
  console.log(BaseApi, path);
  const res = await fetch(`${BaseApi}${path}`, init);
  const text = await res.text();
  let data: any = null;
  if (text) {
    try {
      data = JSON.parse(text);
    } catch {
      data = text;
    }
  }

  console.log(data);

  if (!res.ok) {
    const message = data?.message || `${res.status} ${res.statusText}`;
    throw new Error(message);
  }

  return data;
}

export async function fetchFlights(): Promise<Flight[]> {
  console.log("5545");
  return fetchApi("/flights");
}

export async function fetchFlightById(id: number): Promise<Flight> {
  return fetchApi(`/flights/${encodeURIComponent(id)}`);
}

export async function fetchSerachFlight(
  params: SearchFlight
): Promise<Flight[]> {
  const query = new URLSearchParams();

  if (params.origin) query.append("Origin", params.origin);
  if (params.destination) query.append("destination", params.destination);
  if (params.departureDate) query.append("departureDate", params.departureDate);
  if (params.cabinClass) query.append("cabinClass", params.cabinClass);

  return fetchApi(`/flights/search?${query.toString()}`);
}
