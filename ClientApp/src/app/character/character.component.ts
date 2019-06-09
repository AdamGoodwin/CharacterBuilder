import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-character',
  templateUrl: './character.component.html'
})
export class CharacterComponent {
  public character: Character;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    http.get<Character>(baseUrl + 'api/Character/GetCharacter').subscribe(result => {
      this.character = result;
    }, error => console.error(error));

  }
}

interface Character {
  name: string;
  id: number;
}
