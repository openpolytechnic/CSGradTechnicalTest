import { ChangeDetectionStrategy, Component, Input, OnInit, ViewEncapsulation } from "@angular/core";
import { Superhero } from "../datacontract/superhero.datacontract";

@Component({
  selector: 'op-superheroes-table',
  templateUrl: './superheroes-table.component.html',
  styleUrls: ['./superheroes-table.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
  encapsulation: ViewEncapsulation.None})
export class SuperheroesTableComponent implements OnInit{

  @Input() superheroes: Array<Superhero>;
  loadingPlaceholders: Array<Superhero> = new Array<Superhero>();
  constructor() { }

  public ngOnInit(): void {
    this.loadingPlaceholders.length = 5;
  }
}
