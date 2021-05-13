import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { StudentsDetails } from '../../class/students-details';
import { StudentService } from 'src/app/services/student.service';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.css']
})
export class StudentsComponent implements OnInit {
  public studentsList: StudentsDetails[];

  constructor(private studentService: StudentService) { }

  ngOnInit() {
    this.getStudents();
  }
  getStudents() {
    this.studentService.getStudents().subscribe(result => {
      this.studentsList = result;
    }, error => console.error(error));
  }
  search(text: string) {
    if (!text) {
      this.getStudents();
    } else {
      this.studentService.search(text).subscribe(result => {
        this.studentsList = result;
      }, error => console.error(error));
    }
  }
}
