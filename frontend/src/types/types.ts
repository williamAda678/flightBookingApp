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

export type SearchFlight = {
  origin: string;
  destination: string;
  departureDate: string;
  cabinClass: string;
};
