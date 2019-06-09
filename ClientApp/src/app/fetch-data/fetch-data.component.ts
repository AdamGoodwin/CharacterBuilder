import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public character: Character;
  public blah: any;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    http.get<Character>(baseUrl + 'api/Character/GetCharacter').subscribe(result => {

      this.character = result;
      console.log(result);
      console.log(this.character);
    }, error => console.error(error));

  }
}

interface Character {
  name: string;
  id: number;
}
