using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ManangerApi.Data.Migrations
{
    public partial class contato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    Codigo = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Uf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Competencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CondicaoClinica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicaoClinica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EspecialidadeMedica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspecialidadeMedica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    CodigoUf = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Uf = table.Column<string>(nullable: true),
                    Regiao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posologia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posologia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sexo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusEntidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Referencia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusEntidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoContato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoContato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoMedicamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMedicamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadeDeMedida",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeDeMedida", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    Cpf = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Comentario = table.Column<string>(nullable: true),
                    Termos = table.Column<bool>(nullable: false),
                    Aprovado = table.Column<bool>(nullable: false),
                    Analisado = table.Column<bool>(nullable: false),
                    Imagem = table.Column<string>(nullable: true),
                    Curriculo = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ViaDeUsoMedicamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViaDeUsoMedicamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionalidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    PerfilId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionalidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionalidade_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    TipoContatoId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Comentario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contato_TipoContato_TipoContatoId",
                        column: x => x.TipoContatoId,
                        principalTable: "TipoContato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Acesso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    PerfilId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acesso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Acesso_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Acesso_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Beneficiario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    ContratanteId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    Telefone = table.Column<string>(nullable: true),
                    CidadeId = table.Column<int>(nullable: false),
                    EstadoId = table.Column<int>(nullable: false),
                    Rua = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    TermoDeResponsalidade = table.Column<bool>(nullable: false),
                    Numero = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beneficiario_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Beneficiario_Usuario_ContratanteId",
                        column: x => x.ContratanteId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Beneficiario_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    Cep = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Rua = table.Column<string>(nullable: true),
                    CidadeId = table.Column<int>(nullable: false),
                    EstadoId = table.Column<int>(nullable: false),
                    Numero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Endereco_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Endereco_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrestadorDeServicoCompetencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    PrestadorDeServicoId = table.Column<int>(nullable: false),
                    CompetenciaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestadorDeServicoCompetencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrestadorDeServicoCompetencia_Competencia_CompetenciaId",
                        column: x => x.CompetenciaId,
                        principalTable: "Competencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrestadorDeServicoCompetencia_Usuario_PrestadorDeServicoId",
                        column: x => x.PrestadorDeServicoId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    ContraIndicacao = table.Column<string>(nullable: true),
                    Bula = table.Column<string>(nullable: true),
                    Indicao = table.Column<string>(nullable: true),
                    TipoMedicamentoId = table.Column<int>(nullable: false),
                    ViaDeUsoMedicamentoId = table.Column<int>(nullable: false),
                    EfeitoColateral = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicamento_TipoMedicamento_TipoMedicamentoId",
                        column: x => x.TipoMedicamentoId,
                        principalTable: "TipoMedicamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicamento_ViaDeUsoMedicamento_ViaDeUsoMedicamentoId",
                        column: x => x.ViaDeUsoMedicamentoId,
                        principalTable: "ViaDeUsoMedicamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BeneficiarioCondicaoClinica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    BeneficiarioId = table.Column<int>(nullable: false),
                    CondicaoClinicaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficiarioCondicaoClinica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BeneficiarioCondicaoClinica_Beneficiario_BeneficiarioId",
                        column: x => x.BeneficiarioId,
                        principalTable: "Beneficiario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BeneficiarioCondicaoClinica_CondicaoClinica_CondicaoClinica~",
                        column: x => x.CondicaoClinicaId,
                        principalTable: "CondicaoClinica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicoBeneficiario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    BeneficiarioId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    TelefoneConsultorio = table.Column<int>(nullable: false),
                    Celular = table.Column<int>(nullable: false),
                    EspecialidadeMedicoId = table.Column<int>(nullable: false),
                    EspecialidadeMedicaId = table.Column<int>(nullable: true),
                    Convenio = table.Column<bool>(nullable: false),
                    Cep = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Rua = table.Column<string>(nullable: true),
                    CidadeId = table.Column<int>(nullable: false),
                    EstadoId = table.Column<int>(nullable: false),
                    Numero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoBeneficiario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicoBeneficiario_Beneficiario_BeneficiarioId",
                        column: x => x.BeneficiarioId,
                        principalTable: "Beneficiario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicoBeneficiario_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicoBeneficiario_EspecialidadeMedica_EspecialidadeMedicaId",
                        column: x => x.EspecialidadeMedicaId,
                        principalTable: "EspecialidadeMedica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicoBeneficiario_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolicitacaoContrato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    ContratanteId = table.Column<int>(nullable: false),
                    PrestadorDeServicoId = table.Column<int>(nullable: false),
                    BeneficiarioId = table.Column<int>(nullable: false),
                    DataSolicitacao = table.Column<DateTime>(nullable: false),
                    Comentario = table.Column<string>(nullable: true),
                    DataFim = table.Column<DateTime>(nullable: true),
                    TempoIndeterminado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitacaoContrato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitacaoContrato_Beneficiario_BeneficiarioId",
                        column: x => x.BeneficiarioId,
                        principalTable: "Beneficiario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitacaoContrato_Usuario_ContratanteId",
                        column: x => x.ContratanteId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitacaoContrato_Usuario_PrestadorDeServicoId",
                        column: x => x.PrestadorDeServicoId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tarefa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    BeneficiarioId = table.Column<int>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    HoraInicio = table.Column<TimeSpan>(nullable: false),
                    HoraFim = table.Column<TimeSpan>(nullable: false),
                    CorHexa = table.Column<string>(nullable: true),
                    Comentario = table.Column<string>(nullable: true),
                    TodosOsDias = table.Column<bool>(nullable: false),
                    BeneficiarioMedicamentoId = table.Column<int>(nullable: true),
                    QuantidadeMedicamento = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarefa_Beneficiario_BeneficiarioId",
                        column: x => x.BeneficiarioId,
                        principalTable: "Beneficiario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BeneficiarioMedicamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    BeneficiarioId = table.Column<int>(nullable: false),
                    MedicamentoId = table.Column<int>(nullable: false),
                    PosologiaId = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    EmbalagemQTD = table.Column<double>(nullable: false),
                    UnidadeMedida = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficiarioMedicamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BeneficiarioMedicamento_Beneficiario_BeneficiarioId",
                        column: x => x.BeneficiarioId,
                        principalTable: "Beneficiario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BeneficiarioMedicamento_Medicamento_MedicamentoId",
                        column: x => x.MedicamentoId,
                        principalTable: "Medicamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BeneficiarioMedicamento_Posologia_PosologiaId",
                        column: x => x.PosologiaId,
                        principalTable: "Posologia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contrato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    SolicitacaoContratoId = table.Column<int>(nullable: false),
                    ContratanteId = table.Column<int>(nullable: false),
                    BeneficiarioId = table.Column<int>(nullable: false),
                    PrestadorDeServicoId = table.Column<int>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    ComentarioEncerramentoPrestador = table.Column<string>(nullable: true),
                    ComentarioEncerramentoContratante = table.Column<string>(nullable: true),
                    EncerradoPorContratante = table.Column<bool>(nullable: true),
                    AvaliacaoContratante = table.Column<double>(nullable: true),
                    AvaliacaoPrestador = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contrato_Beneficiario_BeneficiarioId",
                        column: x => x.BeneficiarioId,
                        principalTable: "Beneficiario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contrato_Usuario_ContratanteId",
                        column: x => x.ContratanteId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contrato_Usuario_PrestadorDeServicoId",
                        column: x => x.PrestadorDeServicoId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contrato_SolicitacaoContrato_SolicitacaoContratoId",
                        column: x => x.SolicitacaoContratoId,
                        principalTable: "SolicitacaoContrato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TarefaRalizada",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status = table.Column<int>(nullable: false),
                    TarefaId = table.Column<int>(nullable: false),
                    Comentario = table.Column<string>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    Hora = table.Column<TimeSpan>(nullable: false),
                    Realizada = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarefaRalizada", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TarefaRalizada_Tarefa_TarefaId",
                        column: x => x.TarefaId,
                        principalTable: "Tarefa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acesso_PerfilId",
                table: "Acesso",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Acesso_UsuarioId",
                table: "Acesso",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiario_CidadeId",
                table: "Beneficiario",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiario_ContratanteId",
                table: "Beneficiario",
                column: "ContratanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiario_EstadoId",
                table: "Beneficiario",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_BeneficiarioCondicaoClinica_BeneficiarioId",
                table: "BeneficiarioCondicaoClinica",
                column: "BeneficiarioId");

            migrationBuilder.CreateIndex(
                name: "IX_BeneficiarioCondicaoClinica_CondicaoClinicaId",
                table: "BeneficiarioCondicaoClinica",
                column: "CondicaoClinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_BeneficiarioMedicamento_BeneficiarioId",
                table: "BeneficiarioMedicamento",
                column: "BeneficiarioId");

            migrationBuilder.CreateIndex(
                name: "IX_BeneficiarioMedicamento_MedicamentoId",
                table: "BeneficiarioMedicamento",
                column: "MedicamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_BeneficiarioMedicamento_PosologiaId",
                table: "BeneficiarioMedicamento",
                column: "PosologiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_TipoContatoId",
                table: "Contato",
                column: "TipoContatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_BeneficiarioId",
                table: "Contrato",
                column: "BeneficiarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_ContratanteId",
                table: "Contrato",
                column: "ContratanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_PrestadorDeServicoId",
                table: "Contrato",
                column: "PrestadorDeServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_SolicitacaoContratoId",
                table: "Contrato",
                column: "SolicitacaoContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_CidadeId",
                table: "Endereco",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_EstadoId",
                table: "Endereco",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_UsuarioId",
                table: "Endereco",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Funcionalidade_PerfilId",
                table: "Funcionalidade",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicamento_TipoMedicamentoId",
                table: "Medicamento",
                column: "TipoMedicamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicamento_ViaDeUsoMedicamentoId",
                table: "Medicamento",
                column: "ViaDeUsoMedicamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoBeneficiario_BeneficiarioId",
                table: "MedicoBeneficiario",
                column: "BeneficiarioId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoBeneficiario_CidadeId",
                table: "MedicoBeneficiario",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoBeneficiario_EspecialidadeMedicaId",
                table: "MedicoBeneficiario",
                column: "EspecialidadeMedicaId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoBeneficiario_EstadoId",
                table: "MedicoBeneficiario",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_PrestadorDeServicoCompetencia_CompetenciaId",
                table: "PrestadorDeServicoCompetencia",
                column: "CompetenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_PrestadorDeServicoCompetencia_PrestadorDeServicoId",
                table: "PrestadorDeServicoCompetencia",
                column: "PrestadorDeServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoContrato_BeneficiarioId",
                table: "SolicitacaoContrato",
                column: "BeneficiarioId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoContrato_ContratanteId",
                table: "SolicitacaoContrato",
                column: "ContratanteId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoContrato_PrestadorDeServicoId",
                table: "SolicitacaoContrato",
                column: "PrestadorDeServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarefa_BeneficiarioId",
                table: "Tarefa",
                column: "BeneficiarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TarefaRalizada_TarefaId",
                table: "TarefaRalizada",
                column: "TarefaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acesso");

            migrationBuilder.DropTable(
                name: "BeneficiarioCondicaoClinica");

            migrationBuilder.DropTable(
                name: "BeneficiarioMedicamento");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "Contrato");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Funcionalidade");

            migrationBuilder.DropTable(
                name: "MedicoBeneficiario");

            migrationBuilder.DropTable(
                name: "PrestadorDeServicoCompetencia");

            migrationBuilder.DropTable(
                name: "Sexo");

            migrationBuilder.DropTable(
                name: "StatusEntidade");

            migrationBuilder.DropTable(
                name: "TarefaRalizada");

            migrationBuilder.DropTable(
                name: "UnidadeDeMedida");

            migrationBuilder.DropTable(
                name: "CondicaoClinica");

            migrationBuilder.DropTable(
                name: "Medicamento");

            migrationBuilder.DropTable(
                name: "Posologia");

            migrationBuilder.DropTable(
                name: "TipoContato");

            migrationBuilder.DropTable(
                name: "SolicitacaoContrato");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "EspecialidadeMedica");

            migrationBuilder.DropTable(
                name: "Competencia");

            migrationBuilder.DropTable(
                name: "Tarefa");

            migrationBuilder.DropTable(
                name: "TipoMedicamento");

            migrationBuilder.DropTable(
                name: "ViaDeUsoMedicamento");

            migrationBuilder.DropTable(
                name: "Beneficiario");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Estado");
        }
    }
}
