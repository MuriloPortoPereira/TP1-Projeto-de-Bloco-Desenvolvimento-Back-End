// Variáveis para armazenar os dados do animal, veterinário e consulta

int opcao;
int idade = 0;
int diaSemana = 0;
int horaConsulta = 0;
int minutoConsulta = 0;

string nomeAnimal = "";
string especie = "";
string tutor = "";
string telefone = "";
string nomeVeterinario = "";
string crmv = "";
string dataConsulta = "";
string situacaoConsulta = "";
string observacoes = "";

// bool guarda apenas true ou false e começa como false porque ainda não existe animal cadastrado
bool animalCadastrado = false;

// Informa se o cadastro do veterinário já foi concluído
bool veterinarioCadastrado = false;

// Informa se uma consulta já foi criada
bool consultaExiste = false;

Console.WriteLine("Bem-vindo ao VidaPet!");

do
{
    Console.WriteLine("\n=== Sistema VidaPet ===");
    Console.WriteLine("1 - Cadastrar animal");
    Console.WriteLine("2 - Cadastrar veterinário");
    Console.WriteLine("3 - Agendar consulta");
    Console.WriteLine("4 - Cancelar consulta");
    Console.WriteLine("5 - Consultar agenda");
    Console.WriteLine("6 - Registrar atendimento");
    Console.WriteLine("0 - Encerrar\n");
    Console.Write("Selecione uma opção: ");

    // O TryParse tenta transformar o texto digitado em número
    // O out guarda o resultado convertido dentro da variável opcao
    // opcaoValida recebe true quando consegue converter ou false quando não consegue
    bool opcaoValida = int.TryParse(Console.ReadLine(), out opcao);

    // O ! significa "não" e verifica quando opcaoValida está false
    if (!opcaoValida){

        opcao = -1;

    }

    Console.Clear();

    switch (opcao){

        case 1:

            int confirmarNome = 0;
            int opcaoEspecie = 0;
            int confirmarEspecie = 0;
            int confirmarIdade = 0;
            int confirmarTutor = 0;
            int confirmarTelefone = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Cadastrar animal ===\n");
                Console.Write("Digite o nome do animal: ");

                // O ?? usa um texto vazio se o ReadLine retornar null

                nomeAnimal = Console.ReadLine() ?? "";

                if (nomeAnimal == ""){

                    confirmarNome = 0;
                    Console.WriteLine("\nO nome não pode ficar vazio.");
                    Console.ReadKey();

                }

                else{

                    Console.WriteLine($"\nNome informado: {nomeAnimal}");
                    Console.Write("Digite 1 para confirmar ou 0 para corrigir: ");

                    // Converte a confirmação para int e guarda o resultado em confirmarNome
                    int.TryParse(Console.ReadLine(), out confirmarNome);

                    if (confirmarNome == 0){

                        Console.WriteLine("\nDigite o nome novamente.");
                        Console.ReadKey();

                    }

                    else if (confirmarNome != 1){

                        Console.WriteLine("\nOpção inválida.");
                        Console.ReadKey();

                    }
                }

            } while (confirmarNome != 1);

            // Repete até o usuário confirmar a espécie
            do
            {
                Console.Clear();
                Console.WriteLine("=== Cadastrar animal ===\n");
                Console.WriteLine("=== Ficha atual ===");
                Console.WriteLine($"Nome: {nomeAnimal}");
                Console.WriteLine("-------------------\n");
                Console.WriteLine("Selecione a espécie:");
                Console.WriteLine("1 - Gato");
                Console.WriteLine("2 - Cachorro");
                Console.Write("\nSelecione uma opção: ");

                // Converte a opção para int e guarda o resultado em opcaoEspecie
                int.TryParse(Console.ReadLine(), out opcaoEspecie);

                if (opcaoEspecie == 1){

                    especie = "Gato";

                }

                else if (opcaoEspecie == 2){

                    especie = "Cachorro";

                }

                else{

                    especie = "";
                    confirmarEspecie = 0;
                    Console.WriteLine("\nOpção inválida.");
                    Console.ReadKey();

                }

                if (especie != ""){

                    Console.WriteLine($"\nEspécie informada: {especie}");
                    Console.Write("Digite 1 para confirmar ou 0 para corrigir: ");

                    // Converte a confirmação para int e guarda o resultado em confirmarEspecie
                    int.TryParse(Console.ReadLine(), out confirmarEspecie);

                    if (confirmarEspecie == 0){

                        Console.WriteLine("\nSelecione a espécie novamente.");
                        Console.ReadKey();

                    }

                    else if (confirmarEspecie != 1){

                        Console.WriteLine("\nOpção inválida.");
                        Console.ReadKey();

                    }
                }

            } while (confirmarEspecie != 1);

            // Repete até o usuário confirmar uma idade válida
            do
            {
                Console.Clear();
                Console.WriteLine("=== Cadastrar animal ===\n");
                Console.WriteLine("=== Ficha atual ===");
                Console.WriteLine($"Nome: {nomeAnimal}");
                Console.WriteLine($"Espécie: {especie}");
                Console.WriteLine("-------------------\n");
                Console.Write("Digite a idade do animal: ");

                // O TryParse tenta converter a idade para int e o out guarda o resultado em idade
                // idadeValida recebe true se a conversão funcionar ou false se não funcionar
                bool idadeValida = int.TryParse(Console.ReadLine(), out idade);

                // O ! significa "não" e o || significa "ou"
                // A idade será inválida se não for número ou se for negativa
                if (!idadeValida || idade < 0){

                    confirmarIdade = 0;
                    Console.WriteLine("\nIdade inválida.");
                    Console.ReadKey();

                }

                else{

                    Console.WriteLine($"\nIdade informada: {idade}");
                    Console.Write("Digite 1 para confirmar ou 0 para corrigir: ");

                    // Converte a confirmação para int e guarda o resultado em confirmarIdade
                    int.TryParse(Console.ReadLine(), out confirmarIdade);

                    if (confirmarIdade == 0){

                        Console.WriteLine("\nDigite a idade novamente.");
                        Console.ReadKey();

                    }

                    else if (confirmarIdade != 1){

                        Console.WriteLine("\nOpção inválida.");
                        Console.ReadKey();

                    }
                }

            } while (confirmarIdade != 1);

            // Repete até o usuário confirmar o tutor
            do
            {
                Console.Clear();
                Console.WriteLine("=== Cadastrar animal ===\n");
                Console.WriteLine("=== Ficha atual ===");
                Console.WriteLine($"Nome: {nomeAnimal}");
                Console.WriteLine($"Espécie: {especie}");
                Console.WriteLine($"Idade: {idade}");
                Console.WriteLine("-------------------\n");
                Console.Write("Digite o nome do tutor: ");

                tutor = Console.ReadLine() ?? "";

                if (tutor == ""){

                    confirmarTutor = 0;
                    Console.WriteLine("\nO nome do tutor não pode ficar vazio.");
                    Console.ReadKey();

                }

                else{

                    Console.WriteLine($"\nTutor informado: {tutor}");
                    Console.Write("Digite 1 para confirmar ou 0 para corrigir: ");

                    // Converte a confirmação para int e guarda o resultado em confirmarTutor
                    int.TryParse(Console.ReadLine(), out confirmarTutor);

                    if (confirmarTutor == 0){

                        Console.WriteLine("\nDigite o tutor novamente.");
                        Console.ReadKey();

                    }

                    else if (confirmarTutor != 1){

                        Console.WriteLine("\nOpção inválida.");
                        Console.ReadKey();

                    }
                }
            } while (confirmarTutor != 1);

            // Repete até o usuário confirmar o telefone
            do
            {
                Console.Clear();
                Console.WriteLine("=== Cadastrar animal ===\n");
                Console.WriteLine("=== Ficha atual ===");
                Console.WriteLine($"Nome: {nomeAnimal}");
                Console.WriteLine($"Espécie: {especie}");
                Console.WriteLine($"Idade: {idade}");
                Console.WriteLine($"Tutor: {tutor}");
                Console.WriteLine("-------------------\n");
                Console.Write("Digite o telefone do tutor: ");

                telefone = Console.ReadLine() ?? "";

                if (telefone == ""){

                    confirmarTelefone = 0;
                    Console.WriteLine("\nO telefone não pode ficar vazio.");
                    Console.ReadKey();

                }

                else{

                    Console.WriteLine($"\nTelefone informado: {telefone}");
                    Console.Write("Digite 1 para confirmar ou 0 para corrigir: ");

                    // Converte a confirmação para int e guarda o resultado em confirmarTelefone
                    int.TryParse(Console.ReadLine(), out confirmarTelefone);

                    if (confirmarTelefone == 0){

                        Console.WriteLine("\nDigite o telefone novamente.");
                        Console.ReadKey();

                    }

                    else if (confirmarTelefone != 1){

                        Console.WriteLine("\nOpção inválida.");
                        Console.ReadKey();

                    }
                }

            } while (confirmarTelefone != 1);

            // Muda para true porque o cadastro do animal foi concluído
            animalCadastrado = true;

            Console.Clear();
            Console.WriteLine("=== Animal cadastrado ===\n");
            Console.WriteLine($"Nome: {nomeAnimal}");
            Console.WriteLine($"Espécie: {especie}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Tutor: {tutor}");
            Console.WriteLine($"Telefone: {telefone}");
            Console.WriteLine("\nCadastro realizado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();

            break;

        case 2:

            int confirmarNomeVeterinario = 0;
            int confirmarCrmv = 0;
            // Repete até o usuário confirmar o nome
            do
            {
                Console.Clear();
                Console.WriteLine("=== Cadastrar veterinário ===\n");
                Console.Write("Digite o nome do veterinário: ");

                nomeVeterinario = Console.ReadLine() ?? "";

                if (nomeVeterinario == ""){

                    confirmarNomeVeterinario = 0;
                    Console.WriteLine("\nO nome não pode ficar vazio.");
                    Console.ReadKey();

                }

                else{

                    Console.WriteLine($"\nNome informado: {nomeVeterinario}");
                    Console.Write("Digite 1 para confirmar ou 0 para corrigir: ");

                    // Converte a confirmação para int e guarda o resultado em confirmarNomeVeterinario
                    int.TryParse(Console.ReadLine(), out confirmarNomeVeterinario);

                    if (confirmarNomeVeterinario == 0){

                        Console.WriteLine("\nDigite o nome novamente.");
                        Console.ReadKey();

                    }

                    else if (confirmarNomeVeterinario != 1){

                        Console.WriteLine("\nOpção inválida.");
                        Console.ReadKey();

                    }
                }
            } while (confirmarNomeVeterinario != 1);

            // Repete até o usuário confirmar o CRMV
            do
            {
                Console.Clear();
                Console.WriteLine("=== Cadastrar veterinário ===\n");
                Console.WriteLine("=== Ficha atual ===");
                Console.WriteLine($"Nome: {nomeVeterinario}");
                Console.WriteLine("-------------------\n");
                Console.Write("Digite o CRMV: ");

                crmv = Console.ReadLine() ?? "";

                if (crmv == ""){

                    confirmarCrmv = 0;
                    Console.WriteLine("\nO CRMV não pode ficar vazio.");
                    Console.ReadKey();

                }

                else{

                    Console.WriteLine($"\nCRMV informado: {crmv}");
                    Console.Write("Digite 1 para confirmar ou 0 para corrigir: ");

                    // Converte a confirmação para int e guarda o resultado em confirmarCrmv
                    int.TryParse(Console.ReadLine(), out confirmarCrmv);

                    if (confirmarCrmv == 0){

                        Console.WriteLine("\nDigite o CRMV novamente.");
                        Console.ReadKey();

                    }

                    else if (confirmarCrmv != 1){

                        Console.WriteLine("\nOpção inválida.");
                        Console.ReadKey();

                    }
                }

            } while (confirmarCrmv != 1);

            // Muda para true porque o cadastro do veterinário foi concluído
            veterinarioCadastrado = true;

            Console.Clear();
            Console.WriteLine("=== Veterinário cadastrado ===\n");
            Console.WriteLine($"Nome: {nomeVeterinario}");
            Console.WriteLine($"CRMV: {crmv}");
            Console.WriteLine("\nCadastro realizado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();

            break;

        case 3:

            Console.Clear();
            Console.WriteLine("=== Agendar consulta ===\n");

            // O ! significa "não" e o || significa "ou"
            // Entra neste if se o animal ou o veterinário ainda não estiver cadastrado

            if (!animalCadastrado || !veterinarioCadastrado){

                Console.WriteLine("Cadastre um animal e um veterinário primeiro.");

            }

            // O && significa "e" e exige que as duas condições sejam verdadeiras
            else if (consultaExiste && situacaoConsulta == "Agendada"){

                Console.WriteLine("Já existe uma consulta agendada.");

            }

            else{

                Console.WriteLine("=== Dados selecionados ===");
                Console.WriteLine($"Animal: {nomeAnimal}");
                Console.WriteLine($"Veterinário: {nomeVeterinario}");
                Console.WriteLine($"CRMV: {crmv}");
                Console.WriteLine("--------------------------\n");
                Console.Write("Digite a data da consulta: ");
                dataConsulta = Console.ReadLine() ?? "";

                Console.WriteLine("\nSelecione o dia da semana:");
                Console.WriteLine("1 - Segunda-feira");
                Console.WriteLine("2 - Terça-feira");
                Console.WriteLine("3 - Quarta-feira");
                Console.WriteLine("4 - Quinta-feira");
                Console.WriteLine("5 - Sexta-feira");
                Console.WriteLine("6 - Sábado");
                Console.WriteLine("7 - Domingo");
                Console.Write("\nDia: ");

                // Converte o dia para int e guarda o resultado em diaSemana
                int.TryParse(Console.ReadLine(), out diaSemana);

                Console.Write("Hora: ");
                // Converte a hora para int e guarda o resultado em horaConsulta
                int.TryParse(Console.ReadLine(), out horaConsulta);

                Console.Write("Minutos: ");
                // Converte os minutos para int e guarda o resultado em minutoConsulta
                int.TryParse(Console.ReadLine(), out minutoConsulta);

                // Transforma o horário informado em minutos
                int horarioInicial = (horaConsulta * 60) + minutoConsulta;

                // Adiciona os 30 minutos da consulta
                int horarioFinal = horarioInicial + 30;

                // Verifica se o dia está entre segunda e sexta
                // O && verifica se as duas comparações são verdadeiras ao mesmo tempo
                bool diaValido = diaSemana >= 1 && diaSemana <= 5;

                // 480 minutos representam 08:00 e 1080 representam 18:00
                // Cada && acrescenta uma condição que também precisa ser verdadeira
                bool horarioValido = horaConsulta >= 0 && horaConsulta <= 23 && minutoConsulta >= 0 && minutoConsulta <= 59 && horarioInicial >= 480 && horarioFinal <= 1080;

                if (dataConsulta == ""){

                    Console.WriteLine("\nA data é obrigatória.");

                }

                else if (!diaValido){

                    Console.WriteLine("\nA clínica atende de segunda a sexta.");

                }

                else if (!horarioValido){

                    Console.WriteLine("\nHorário inválido.");
                    Console.WriteLine("As consultas acontecem das 08:00 às 18:00.");
                }

                else{

                    consultaExiste = true;
                    situacaoConsulta = "Agendada";
                    Console.WriteLine("\n=== Consulta agendada ===");
                    Console.WriteLine($"Animal: {nomeAnimal}");
                    Console.WriteLine($"Veterinário: {nomeVeterinario}");
                    Console.WriteLine($"Data: {dataConsulta}");
                    // D2 mostra o número com dois dígitos
                    Console.WriteLine($"Horário: {horaConsulta:D2}:{minutoConsulta:D2}");
                    Console.WriteLine($"Situação: {situacaoConsulta}");

                }
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar...");
            Console.ReadKey();
            Console.Clear();

            break;

        case 4:

            Console.Clear();
            Console.WriteLine("=== Cancelar consulta ===\n");

            if (!consultaExiste){

                Console.WriteLine("Não existe uma consulta cadastrada.");

            }

            else if (situacaoConsulta == "Agendada"){

                Console.WriteLine($"Animal: {nomeAnimal}");
                Console.WriteLine($"Veterinário: {nomeVeterinario}");
                Console.WriteLine($"Data: {dataConsulta}");
                Console.WriteLine($"Horário: {horaConsulta:D2}:{minutoConsulta:D2}");
                Console.Write("\nDigite 1 para confirmar o cancelamento: ");

                // Converte a confirmação e cria a variável confirmarCancelamento com o resultado
                int.TryParse(Console.ReadLine(), out int confirmarCancelamento);

                if (confirmarCancelamento == 1){

                    situacaoConsulta = "Cancelada";
                    Console.WriteLine("\nConsulta cancelada.");

                }

                else{

                    Console.WriteLine("\nCancelamento não realizado.");

                }
            }

            else{

                Console.WriteLine($"A consulta está como {situacaoConsulta}.");
                Console.WriteLine("Somente consultas agendadas podem ser canceladas.");

            }

            Console.WriteLine("\nPressione qualquer tecla para voltar...");
            Console.ReadKey();
            Console.Clear();

            break;

        case 5:

            Console.Clear();
            Console.WriteLine("=== Consultar agenda ===\n");

            if (!consultaExiste){

                Console.WriteLine("Não existe uma consulta cadastrada.");

            }

            else{

                Console.WriteLine("=== Consulta encontrada ===");
                Console.WriteLine($"Animal: {nomeAnimal}");
                Console.WriteLine($"Espécie: {especie}");
                Console.WriteLine($"Tutor: {tutor}");
                Console.WriteLine($"Veterinário: {nomeVeterinario}");
                Console.WriteLine($"CRMV: {crmv}");
                Console.WriteLine($"Data: {dataConsulta}");
                Console.WriteLine($"Horário: {horaConsulta:D2}:{minutoConsulta:D2}");
                Console.WriteLine($"Situação: {situacaoConsulta}");

                // O != significa "diferente de" e verifica se observacoes possui algum texto
                if (observacoes != ""){

                    Console.WriteLine($"Observações: {observacoes}");

                }
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar...");
            Console.ReadKey();
            Console.Clear();

            break;

        case 6:

            Console.Clear();
            Console.WriteLine("=== Registrar atendimento ===\n");

            if (!consultaExiste){

                Console.WriteLine("Não existe uma consulta cadastrada.");

            }

            else if (situacaoConsulta != "Agendada"){

                Console.WriteLine($"A consulta está como {situacaoConsulta}.");
                Console.WriteLine("Somente consultas agendadas podem ser realizadas.");

            }

            else{

                Console.Write("Digite o CRMV do veterinário responsável: ");

                // O ?? usa um texto vazio se o ReadLine retornar null
                string crmvInformado = Console.ReadLine() ?? "";

                // O != significa "diferente de" e compara os dois CRMVs
                if (crmvInformado != crmv){

                    Console.WriteLine("\nSomente o veterinário responsável pode registrar o atendimento.");

                }

                else{

                    Console.Write("Digite as observações do atendimento: ");
                    observacoes = Console.ReadLine() ?? "";
                    // O ?? verifica se o Console.ReadLine() retornou null
                    // Se tiver algum texto, ele será guardado em observacoes
                    // Se retornar null, será usado "" como texto vazio

                    if (observacoes == ""){

                        Console.WriteLine("\nAs observações não podem ficar vazias.");

                    }

                    else{

                        situacaoConsulta = "Realizada";
                        Console.WriteLine("\nAtendimento registrado.");
                        Console.WriteLine($"Situação: {situacaoConsulta}");
                        Console.WriteLine($"Observações: {observacoes}");

                    }
                }
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar...");
            Console.ReadKey();
            Console.Clear();

            break;

        case 0:

            Console.WriteLine("Programa encerrado.\n");
            Console.WriteLine("Obrigado por escolher o VidaPet!");

            break;

        default:

            Console.WriteLine("Opção inválida.");
            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
            Console.Clear();

            break;

    }

    // O != significa "diferente de" e mantém o menu enquanto a opção não for 0
} while (opcao != 0);