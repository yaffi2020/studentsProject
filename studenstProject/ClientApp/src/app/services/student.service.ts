import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { StudentsDetails } from '../class/students-details';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }
  getStudents(): Observable<StudentsDetails[]> {
    return this.http.get<StudentsDetails[]>(this.baseUrl + 'studentsDetails');
  }
  search(text: string): Observable<StudentsDetails[]> {
    return this.http.get<StudentsDetails[]>(this.baseUrl + 'studentsDetails/search/' + text);
  }
}
