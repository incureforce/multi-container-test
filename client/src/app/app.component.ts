import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Multi Container Test';

  fromServerTestModel;

  constructor(private http : HttpClient) {
    this.fromServerTestModel = http.get('/api');
  }
}
