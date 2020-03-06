import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { HttpClient } from '@angular/common/http/http';
import { ISubcategoria } from './SubCategoria';

@Injectable({
  providedIn: 'root'
})
export class SubcategoriaService {

  

  private apiURL = this.baseUrl + "api/SubCategoria"

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getSubCategoria(): Observable<ISubcategoria[]> {
    return this.http.get<ISubcategoria[]>(this.apiURL);
  }
}

