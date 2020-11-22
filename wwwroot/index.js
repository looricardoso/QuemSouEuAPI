const iniciar = async () => {
    const nome = document.getElementById('nomeSobrenome');
    const githubuser = document.getElementById('githubUser');
    const response = await fetch('/QuemSouEuAPI');
    const result = await response.json();
    nome.innerText = `Meu nome é ${result.nome} ${result.sobrenome}`;
    githubuser.innerHTML = `Meu usuário no Github é: <a href="https://github.com/${result.githubUser}/" target="_blank">${result.githubUser}</a>`;
};

document.addEventListener('DOMContentLoaded', iniciar);