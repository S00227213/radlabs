import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpParams, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { environment } from '../environments/environment';
import { Contact } from './contact'; 

@Injectable({
    providedIn: 'root'
})
export class ContactService {
    private dataUri = `${environment.apiUri}/contacts`;

    constructor(private http: HttpClient) { }

    private handleError(error: HttpErrorResponse) {
        if (error.status === 0) {
            console.error('An error occurred:', error.error);
        } else {
            console.error(`Backend returned code ${error.status}, body was: `, error.error);
        }
        return throwError(() => new Error('Something bad happened; please try again later.'));
    }

    getContacts(name?: string): Observable<Contact[]> {
        console.log("get contacts called");
        const options = {
            headers: new HttpHeaders().set('X-API-key', 'Jack Monaghan'),
            params: name ? new HttpParams().set('name', name) : {}
        };
  
        return this.http.get<Contact[]>(this.dataUri, options)
            .pipe(
                retry(3),
                catchError(this.handleError)
            );
    }
}
