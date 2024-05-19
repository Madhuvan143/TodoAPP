import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, catchError, throwError } from 'rxjs';
import { error } from 'console';

@Injectable({
  providedIn: 'root'
})
export class TodoService {
  private apiUrl = 'https://localhost:44311/api/services/app/ToDo';

  constructor(private http: HttpClient) { }

  getAll(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/GetAll`).pipe(catchError(this.handleError));
  }

  get(id: number): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/Get?id=${id}`);
  }
  
  private handleError(error: HttpErrorResponse) {
    console.error('An error occurred:', error.message);
    return throwError('Something went wrong; please try again later.');
  }

  create(toDo: any): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/Create`, toDo);
  }

  update(toDo: any): Observable<any> {
    return this.http.put<any>(`${this.apiUrl}/Update`, toDo);
  }

  delete(id: number): Observable<any> {
    return this.http.delete<any>(`${this.apiUrl}/Delete?id=${id}`);
  }
}
