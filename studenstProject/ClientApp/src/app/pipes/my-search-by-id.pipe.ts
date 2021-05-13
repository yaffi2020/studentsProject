import { Pipe, PipeTransform } from '@angular/core';
import { StudentsDetails } from '../class/students-details';

@Pipe({
  name: 'mySearchById'
})
export class MySearchByIdPipe implements PipeTransform {
  results: StudentsDetails[];

  transform(value: StudentsDetails[], resultSearch: string): StudentsDetails[] {
    if (!resultSearch) return value;
    this.results = [];
    for (var i = 0; i < value.length; i++) {
      if (value[i].id==Number(resultSearch) ){
        this.results.push(value[i]);
      }
    }
    return this.results;
  }
}
