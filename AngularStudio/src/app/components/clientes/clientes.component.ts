import { ClientesService } from './../../clientes.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Cliente } from 'src/app/cliente';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css']
})
export class ClientesComponent implements OnInit {

  formulario: any;
  tituloFormulario: string = ' ';

  constructor(private ClientesService: ClientesService) { }

  ngOnInit(): void {

    this.tituloFormulario = 'Nova pessoa';

    this.formulario = new FormGroup({
      nome: new FormControl(null),
      sobrenome: new FormControl(null),
      idade: new FormControl(null),
      profissao: new FormControl(null)
    });
  }
  EnviarFormulario(): void {
    const cliente : Cliente = this.formulario.value;

    this.ClientesService.SalvarCliente(cliente).subscribe(resultado =>{
      alert('Pessoa inserida com sucesso');
    })
  }

}
