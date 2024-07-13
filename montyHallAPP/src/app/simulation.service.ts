// src/app/simulation.service.ts
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

interface SimulationRequest {
  numberOfSimulations: number;
  changeDoor: boolean;
}

interface SimulationResult {
  wins: number;
  losses: number;
}

@Injectable({
  providedIn: 'root'
})

export class SimulationService {
  private apiUrl = 'https://localhost:7083/api/simulation'; // Adjust the URL based on your backend URL

  constructor(private http: HttpClient) {}

  runSimulation(request: SimulationRequest): Observable<SimulationResult> {
    return this.http.post<SimulationResult>(this.apiUrl, request);
  }
}
