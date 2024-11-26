# Jogo-Terror
Trabalho de Computabilidade e Complexidade de Algoritmos dos alunos do 6° Semestre de Ciência da Computação 

Link do Repositorio : https://docs.google.com/document/d/1PrrAdx-OnICCWeQ1nbCfR8MgBROGx4Wt/edit?usp=sharing&ouid=116900395550097482389&rtpof=true&sd=true

# Integrantes

RAIEL

IGOR NUNES

IGOR MIRANDA

# História

O personagem acorda em sua cama após uma longa noite mal dormida. Olha ao redor, meio desorientado, tentando reconhecer o local em que se encontra.

Ao despertar, chama por sua mãe e pai, mas, após um longo e ensurdecedor silêncio, ninguém responde. Ele(a) percebe que está sozinho(a) em casa, mas, por algum motivo, sente-se angustiado(a), como se algo o(a) estivesse observando.

Decide sair de casa o mais rápido possível. Ao ir em direção à porta, tenta abri-la e força a abertura, mas percebe que está trancada. Sem saber o que fazer, lembra que seus pais adoram enigmas e quebra-cabeças. Então, começa a procurar pistas de onde eles poderiam ter escondido a chave de casa.

Após encontrar a chave da porta da frente no porão, escuta um barulho e fica muito assustado(a), nervoso(a) e com medo do que pode ter causado o som. De repente, a luz da casa se apaga, e o personagem fica no breu completo.

Com apenas uma lanterna e um isqueiro no bolso, ele(a) tenta desesperadamente iluminar o ambiente, enquanto o barulho se torna cada vez mais alto.



# Checklist do Desenvolvimento do Jogo
Definição do Tema: Terror,estilo puzzle(treino de habilidades manuais, perceção visual bem como capacidades cognitivas responsáveis pela organização e estratégia do processo de encaixar).

Planejamento:Unity,Design,programação e puzzle para resolver

Desenvolvimento: Implemente o jogo conforme o plano.

Testes: Realize testes para garantir que o jogo funciona corretamente.

Documentação: Documente o código e o processo de desenvolvimento.

# Tecnologias Utilizadas
Unity 

C#

Itch.io

# Identificação da Complexidade do Jogo
Detecção de distância entre dois objetos, checagem de situações correspondentes, criação de puzzles e resolução de puzzles.

A complexidade foi abordada utilizando variáveis, funções, loops de interação, objetos e funções nativas do Unity, além de estruturas condicionais.

# Regras e Jogabilidade
Regras

Cada porta deve possuir uma chave correspondente.
As chaves só podem ser obtidas ao resolver os puzzles propostos.
Jogabilidade

O jogador deve resolver os enigmas para desbloquear as chaves necessárias e alcançar o objetivo principal: o porão.

# Demo do Jogo por Vídeo
link do video: https://youtu.be/l3laDdLt0wc

# Documentation
private void Interation() - Verifica se o personagem está perto de um determinado objeto. Se estiver perto aparece um canvas se pressionar a tecla F equanto o canvas 
estiver ativo acontecera alguma ação de acordo com a função verifyTypeTag(string tag, GameObject interection)

private void verifyTypeTag(string tag, GameObject interection) - verfica a tag de um objeto. Se a tag for item ele adicionara a uma lista de itens, destruira o objeto e 
fechara o canvas, Se a tag for Doors vai verificar se o personagem principal possui o item correspodente há essa door, caso tenha acontecera uma ação se não aparecera uma 
mensagem de erro

private void Move() - Fara a movimentação do personagem

public void fecharButtons() - Verifica se algum menu está aberto, se algum estiver aberto ele é fechado

public void openUnityDocLink() - Abrira uma janela da documentação do unity

public void openGitHubLink() - Abrira uma janela do Git Hub do projeto

private IEnumerator LoadScene() - Vai ser para abrir uma outra scena do unity

private IEnumerator LoadSceneTeste() -  Carregara uma barra de progresso, esse função é mais para fins de teste 
