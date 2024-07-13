import { Component, NgModule } from '@angular/core';
import { SimulationService } from '../simulation.service';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-game',
  standalone: true,
  imports: [FormsModule, HttpClientModule, CommonModule ],
  templateUrl: './game.component.html',
  styleUrl: './game.component.css'
})
export class GameComponent {
  numberOfSimulations : any;
  changeDoor = true;
  result: any = null;

  constructor(private simulationService: SimulationService) {}

  runSimulation() {
    this.simulationService.runSimulation({
      numberOfSimulations: this.numberOfSimulations,
      changeDoor: this.changeDoor
    }).subscribe(result => {
      this.result = result;
    });
  }
}
