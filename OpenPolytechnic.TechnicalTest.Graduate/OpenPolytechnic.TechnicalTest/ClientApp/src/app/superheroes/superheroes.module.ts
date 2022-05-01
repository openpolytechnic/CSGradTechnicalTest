import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { MarvelSuperheroesModule } from "./marvel/marvel.module";
import { SuperheroesComponent } from "./superheroes.component";
import { SuperheroesRouterModule } from "./superheroes.routing";

@NgModule({
  imports: [
    CommonModule,
    SuperheroesRouterModule,
    MarvelSuperheroesModule
  ],
  declarations: [
    SuperheroesComponent
  ],
  exports: [
    SuperheroesComponent
  ]
})
export class SuperheroesModule { }
