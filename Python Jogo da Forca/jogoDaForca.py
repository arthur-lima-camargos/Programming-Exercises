import random

print('>>>>>>>>>>>>>>>>> JOGO DA FORCA <<<<<<<<<<<<<<<<<')
print('>>>>>>>>>>>>>>>>>>  FEITO POR: <<<<<<<<<<<<<<<<<<')
print('>>>>>>>>>>>>>> ARTHUR LIMA CAMARGOS <<<<<<<<<<<<<')
print('\n')

quadro = [
'''
+---+
|   |
    |
    |
    |
    |
=========''', '''

+---+
|   |
O   |
    |
    |
    |
=========''', '''

+---+
|   |
O   |
|   |
    |
    |
=========''', '''

 +---+
 |   |
 O   |
/|   |
     |
     |
=========''', '''

 +---+
 |   |
 O   |
/|\  |
     |
     |
=========''', '''

 +---+
 |   |
 O   |
/|\  |
/    |
     |
=========''', '''

 +---+
 |   |
 O   |
/|\  |
/ \  |
     |
=========''']


class Forca:
    def __init__(self, palavra):
        self.palavra = palavra
        self.letras_erradas = []
        self.letras_certas = []

    def adivinhaLetra(self, letra):
        if letra in self.palavra and letra not in self.letras_certas:
            self.letras_certas.append(letra)
        elif letra not in self.palavra and letra not in self.letras_erradas:
            self.letras_erradas.append(letra)
        else:
            return False
        return True

    def verifica_fim(self):
         return self.verifica_ganhou() or (len(self.letras_erradas) == 6)

    def verifica_ganhou(self):
         if '_' not in self.esconde_letra():
            return True
         return False

    def esconde_letra(self):
         seq = ''
         for letra in self.palavra:
            if letra not in self.letras_certas:
               seq += '_'
            else:
               seq += letra
         return seq

    def imprime_status(self):
         print(quadro[len(self.letras_erradas)])
         print('\nPalavra: ' + self.esconde_letra())
         print('\nLetras erradas: ',)
         for letra in self.letras_erradas:
               print(letra,)
         print()
         print('Letras corretas: ',)
         for letra in self.letras_certas:
               print(letra,)
         print()


def geraPalavra():
    with open("palavras.txt", "rt") as x:
        bd = x.readlines()
    return bd[random.randint(0, len(bd))].strip().upper()


def main():
    jogo = Forca(geraPalavra())
    while not jogo.verifica_fim():
      jogo.imprime_status()
      tentativa = input('Digite uma letra: ').upper()
      jogo.adivinhaLetra(tentativa)
    jogo.imprime_status()
    if jogo.verifica_ganhou():
      print('Parabéns você GANHOU!')
    else:
      print('Que pena, você PERDEU!')
      print('A palavra correta era: ' + jogo.palavra)  
      print('Até a próxima!')

if __name__ == "__main__":
   main()