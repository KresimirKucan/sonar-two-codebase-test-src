import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

export interface ApiResult {
  page: number;
  results: any[];
  total_pages: number;
  total_results: number;
}

export interface Car {
  Id: string;
  Brand: string;
  Year: number;
  Kilometers: number;
  HorsePower: number;
}

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  constructor(private http: HttpClient) { }

  getTopRatedMovies(page = 1): Observable<ApiResult> {
    return this.http.get<ApiResult>(
        `${environment.baseUrl}/movie/popular?api_key=${environment.apiKey}&page=${page}`
      );
  }

  getCars(): Observable<Car> {
    return this.http.get<Car>(
        `https://localhost:7288/api/Car/Get`
      );
  }

  getMovieDetails(id: string) {
    return this.http.get(
      `${environment.baseUrl}/movie/${id}?api_key=${environment.apiKey}`
    );
  }

  getMovieDetailstest(id: string) {
    return this.http.get(
      `${environment.baseUrl}/movie/${id}?api_key=${environment.apiKey}`
    );
  }
}
