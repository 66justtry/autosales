import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent {
  public data: string[] = [];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<string[]>(baseUrl + 'search').subscribe(result => {
      this.data = result;
    }, error => console.error(error));
  }
}
