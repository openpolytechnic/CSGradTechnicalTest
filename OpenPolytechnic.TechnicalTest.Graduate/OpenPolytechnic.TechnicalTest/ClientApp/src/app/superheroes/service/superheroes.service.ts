import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Superhero } from "../datacontract/superhero.datacontract";

@Injectable()
export class SuperheroesService {

  constructor(private httpClient: HttpClient) { }

  public getMarvelSuperheroes(): Observable<Array<Superhero>> {
    return this.httpClient.get<Array<Superhero>>('/api/superheroes/marvel');
  }
}
