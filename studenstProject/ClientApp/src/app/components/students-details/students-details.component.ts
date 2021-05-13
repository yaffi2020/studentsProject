import { Component, OnInit, Inject } from '@angular/core';
import { StudentsDetails } from '../../class/students-details';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-students-details',
  templateUrl: './students-details.component.html',
  styleUrls: ['./students-details.component.css']
})
export class StudentsDetailsComponent implements OnInit {

  public studentList: StudentsDetails[];
  studentId:number; 
  
  constructor(private route: ActivatedRoute,http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.studentId= this.route.snapshot.params['id'];
    http.get<StudentsDetails[]>(baseUrl + 'studentsDetails').subscribe(result => {
      this.studentList = result;
    }, error => console.error(error));
  }

  ngOnInit() {
  }

}
