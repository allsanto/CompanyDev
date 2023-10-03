import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { DiretorComponent } from './diretor/diretor.component';
import { EquipeComponent } from './equipe/equipe.component';
import { FuncionarioComponent } from './funcionario/funcionario.component';
import { GerenteComponent } from './gerente/gerente.component';

@NgModule({
  declarations: [
    AppComponent,
    DiretorComponent,
    EquipeComponent,
    FuncionarioComponent,
    GerenteComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
