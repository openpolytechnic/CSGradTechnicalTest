import { ChangeDetectionStrategy, Component, OnInit, ViewEncapsulation } from "@angular/core";
import { Observable } from "rxjs";
import { Superhero } from "../datacontract/superhero.datacontract";
import { SuperheroesService } from "../service/superheroes.service";

@Component({
  selector: 'op-marvel-superheroes',
  templateUrl: './marvel.component.html',
  styleUrls: ['./marvel.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
  encapsulation: ViewEncapsulation.None
})
export class MarvelSuperheroesComponent implements OnInit {

  public marvelSuperheroes$: Observable<Array<Superhero>>

  constructor(private superheroesService: SuperheroesService) { }

  public ngOnInit(): void {
    this.marvelSuperheroes$ = this.superheroesService.getMarvelSuperheroes();
  }
}
