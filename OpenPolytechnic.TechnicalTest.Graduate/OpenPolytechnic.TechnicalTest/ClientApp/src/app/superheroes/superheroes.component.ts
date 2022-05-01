import { ChangeDetectionStrategy, Component, ViewEncapsulation } from "@angular/core";

@Component({
  selector: 'op-superheroes',
  templateUrl: './superheroes.component.html',
  styleUrls: ['./superheroes.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
  encapsulation: ViewEncapsulation.None
})
export class SuperheroesComponent {

}
