import { FormBuilder, FormGroup } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})


export class LoginComponent implements OnInit {
  uploadForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private httpClient: HttpClient) {
    this.uploadForm = this.formBuilder.group({
      userName: '',
      password: '',
      cPassword: ''
    })
  }


  onSubmit() {
    const HttpOptions = {
      headers: new Headers({
        'Access-Control-Request-Headers': '*',
        'Accept': 'applications/json',
        'Content-Type': 'application/json'
      })
    }
    // User object is being created correctly, just not sending data through the body
    const user = new UserObject(this.uploadForm.value.userName, this.uploadForm.value.password);
    this.httpClient.post<any>("db/adduser", {
        "userId": user.userId,
        "username": user.username,
        "password": user.password
    })
      .subscribe((res: Response) => {
        console.log(res);
      })
  }
  ngOnInit() {

  }
}

 class UserObject {
  userId: number;
  username: string;
  password: string;
  constructor(userName: string, password: string) {
    this.userId = 1;
    this.username = userName;
    this.password = password;
  }
}

