# Equivalencia_entre_programas
Esse é um projeto da disciplina Teoria da computação do Cesupa. O projeto tem como objetivo testar a equivalencia entre programas monoliticos, iterativos e recursivos através do método da máquina de traços.

# 1. Descrição Geral do Jogo de Forca

O jogo de forca é um jogo de adivinhação de palavras onde o jogador tenta descobrir uma palavra oculta adivinhando letras. A cada letra errada, uma parte de um desenho simplificado de uma forca com um enforcado é adicionado. O objetivo é adivinhar a palavra antes que o desenho seja completado, no caso deste programa, o usuário tem 6 tentaivas, mas nao foi implementado o desenho do boneco.
# 2. Implementação dos Programas
# 2.1. Programa Monolítico

Estrutura: Este programa é desenvolvido como um único bloco de código, onde todas as funcionalidades estão integradas em um único módulo. Não há separação entre a lógica de input, processamento de adivinhações e a interface visual. O controle do fluxo do jogo é controlado através de condicionais e o uso do comando goto (Por isso a linguagem escolhida foi C#)
Fluxo de Execução: O jogo inicia e termina dentro de um único loop ou sequência de comandos que processa entradas, atualiza o estado do jogo e renderiza a interface.

# 2.2. Programa Iterativo

Estrutura: Nesta versão, o jogo é estruturado em torno de loops que processam iterativamente as entradas do usuário e atualizam o estado do jogo. A separação entre a lógica de processamento e a interface do usuário é mais clara.
Fluxo de Execução: Utiliza loops para iterar através das entradas do usuário, com funções separadas para verificar a entrada, atualizar o estado do jogo e desenhar a interface.

# 2.3. Programa Recursivo

Estrutura: O jogo utiliza chamadas recursivas para implementar a lógica de adivinhação e atualização do estado do jogo. A recursividade é usada principalmente na lógica de adivinhação e verificação das letras.
Fluxo de Execução: Ao invés de usar loops, o programa utiliza chamadas recursivas para lidar com as adivinhações até que a condição de término (ganhar ou perder o jogo) seja atingida.

# 3. Máquina de Traços para Testar Equivalência

Objetivo: Implementar um método chamado "máquina de traços" que registra e compara a sequência de operações (entrada de letras, atualizações de estado, e saídas gráficas) realizadas pelos três programas durante a execução.
Funcionalidade: A máquina de traços captura as operações como uma série de eventos ou "traços", que são então comparados entre os diferentes tipos de implementação para verificar se, independentemente da estrutura do código, o resultado das operações é consistentemente o mesmo.
Implementação: Pode-se implementar um decorador ou uma interface que intercepta as chamadas de funções e os estados alterados, registrando-os em um log que pode ser analisado posteriormente.

# 4. Comparação e Análise

Para realizar o teste, submeteu-se cada programa a uma única palavra, selecionada de suas respectivas listas de palavras possíveis: "computador". Em seguida, os programas foram iniciados e receberam uma sequência específica de caracteres na seguinte ordem: a, c, o, m, p, u, t, d, r. Após a execução desses testes com o auxílio da máquina de traços, foram registradas as seguintes saídas resultantes:

Programa Monolítico
  ABCDEFHHHHHHHHHHJKFKNOFPPPPPPPQPPPOKFLKNOFPQPPPPPPPPPOKFLLKNOFPPQPPPPPPPQPOKFLLLKNOFPPPQPPPPPPPOKFLLLLKNOFPPPPQPPPPPPOKFLLLLLKNOFPPPPPQPPPPPOKFLLLLLLKNOFPPPPPPQPPPPOKFLLLLLLLKNOFPPPPPPPPQPPOKFLLLLLLLLKNOFPPPPPPPPPPQOS

Programa Iterativo
  ABCDEFHHHHHHHHHHJKFKNOFPPPPPPPQPPPOKFLKNOFPQPPPPPPPPPOKFLLKNOFPPQPPPPPPPQPOKFLLLKNOFPPPQPPPPPPPOKFLLLLKNOFPPPPQPPPPPPOKFLLLLLKNOFPPPPPQPPPPPOKFLLLLLLKNOFPPPPPPQPPPPOKFLLLLLLLKNOFPPPPPPPPQPPOKFLLLLLLLLKNOFPPPPPPPPPPQOS

programa Recursivo:  
    ABCDEFGHHHHHHHHHHJKKNOPPPPPPPQPPPPOKLKNOPQPPPPPPPPPPOKLLKNOPPQPPPPPPPQPPOKLLLKNOPPPQPPPPPPPPOKLLLLKNOPPPPQPPPPPPPOKLLLLLKNOPPPPPQPPPPPPOKLLLLLLKNOPPPPPPQPPPPPOKLLLLLLLKNOPPPPPPPPQPPPOKLLLLLLLLKNOPPPPPPPPPPQPOS

Este projeto não apenas permite a implementação do jogo de forca em diferentes estilos de programação, mas também fornece uma ferramenta robusta para análise e garantia de qualidade do código através da "máquina de traços".
