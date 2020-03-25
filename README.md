# joguin

Projeto proposto no 7º semestre de Ciência da Computação, na disciplina de Computação Gráfica

# Objetivos
* Crie um script para controlar seu personagem andando nas 4 direções básicas (horizontal e vertical). Lembre-se de usar uma
variável pública para determinarmos a velocidade (A,SN).

* Crie um inimigo a cada X segundos (5s) que siga seu personagem (variável pública para determinarmos a velocidade) (S,A,SN).
Sorteie um valor de rotação (Z) do inimigo, entre 0 e 360. Sorteie também a posição inicial do inimigo para que cada um spawne em um
ponto diferente da tela.

* Faça que se o inimigo estiver mais longe do que distância X (teste com 20 unidades), ele anda Y mais rápido (teste com 2 vezes
mais velocidade). Use Vector3.Distance() (M).

* Quando o jogador pressionar o botão esquerdo do mouse, sai um projetil.

* O projetil ao nascer (lembre-se da função Start) deve apontar na direção do mouse e andar nessa direção (variável pública para
determinarmos a velocidade) (At) (S,A,SN).

* Obtenha a direção que o inimigo está olhando, pegando a rotação Z dele e calculando um vetor direção a partir do Cos e Sin
(CS).

* Alterar a lógica do inimigo, para que ele somente ande se o jogador estiver no seu campo de visão (usar um viewConeAngleCosine
de 0.8f).

Para calcular o produto escalar, use o vetor direção do inimigo (calculado no exercício 7) e a subtração do vetor de posição do personagem
pelo inimigo(D).

* Altere a lógica de movimentação do inimigo, para que ele se mova na direção em que está olhando.

* Se o projetil encostar no inimigo, ele morre (Destroy(this.gameObject))

# Tecnologias
* Unity - 2019.3.4f1
