import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Icategoria } from './Categoria';

@Injectable({
  providedIn: 'root'
})
export class CategoriaService {
  private apiURL = this.baseUrl + "api/Categoria"

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getCategoria(): Observable<Icategoria[]> {
    return this.http.get<Icategoria[]>(this.apiURL);
  }
}
