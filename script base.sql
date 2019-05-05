use Mananger

insert into StatusEntidade
values('Ativo'),('Inativo')

insert into Sexo
values(1,'Outro'),(1,'Masculino'),(1,'Feminino')

insert into Perfil
values (1,'Administrador'),(1,'Contratante'), (1,'Gestor'),(1,'Prestador de Servico')


insert into Funcionalidade
(Status,Nome,Path,PerfilId)
values(1,'board','/board',1),
(1,'board','/board',2),
(1,'board','/board',3),
(1,'board','/board',4);

insert into Usuario 
(Nome,Email,Discriminator,Login,Senha,Status,DataNascimento,Sexo,Termos,Aprovado,Analisado)
values('Adm','adm@mananger.com','Administrador','adm','adm',1,'1990-02-20 00:00:00.0000000',1,1, 1,1)


select Id from Usuario where  Discriminator = 'Administrador';

insert into Acesso
(PerfilId,Status,UsuarioId)
values(1,1,1)

	