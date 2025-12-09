export type Flight = {
  flightId: number;
  origin: string;
  destination: string;
  departureTime: string;
  arrivalTime: string;
  airline: string;
  price: number;
  cabinClass?: string;
};
