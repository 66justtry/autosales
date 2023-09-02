import { Component, Inject } from '@angular/core';

@Component({
  selector: 'app-search-form-short',
  templateUrl: './search-form-short.component.html',
  styleUrls: ['./search-form-short.component.css']
})
export class SearchFormShortComponent {
  usedOrNew = 1;
  setUsedOrNew(val: number):void {
    this.usedOrNew = val;
  }
  //submitForm(@Inject('BASE_URL') baseUrl: string) {
  //  const url = baseUrl + 'search?' + new URLSearchParams(formData).toString();
  //  console.log(url);
  //}
}
