export class StudentsDetails {
    constructor(id: number, tz: number, firstName: string, lastName: string,birthDay: Date, gender: string, dateOfRegistration: Date) {
        this.id=id;
        this.tz=tz;
        this.firstName=firstName;
        this.lastName=lastName;
        this.birthDay=birthDay;
        this.gender=gender;
        this.dateOfRegistration=dateOfRegistration;
    }

    id: number;
    tz: number;
    firstName: string;
    lastName: string;
    birthDay: Date;
    gender: string;
    dateOfRegistration: Date;

}
