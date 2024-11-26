[Documentation Unit](https://docs.unity3d.com/ScriptReference/index.html)

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
