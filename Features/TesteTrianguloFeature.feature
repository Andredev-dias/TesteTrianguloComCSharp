Feature: Testar variações de tamanho de um triangulo 

Scenario Outline: Teste de variação de tamanho de um triangulo
	When informar os valores das arestas de um triangulo <x> <y> <z>
	Then a aplicação valida se é um triângulo válido e retorna seu <tipo>

	Examples: 
	| x   | y   | z   | tipo       |
	| 3   | 4   | 5   | Escaleno   |
	| 10  | 10  | 10  | Equilatero |
	| 5   | 5   | 2   | Isoceles   |
	| 2   | 5   | 5   | Isoceles   |
	| 5   | 2   | 5   | Isoceles   |
	| 10  | 10  | 0   | Invalido   |
	| 20  | 20  | 10  | Isoceles   |
	| 10  | 20  | 20  | Isoceles   |
	| 20  | 10  | 20  | Isoceles   |
	| 3   | 4   | 5   | Escaleno   |
	| 4   | 3   | 5   | Escaleno   |
	| 5   | 4   | 3   | Escaleno   |
	| 0   | 0   | 0   | Invalido   |
	| 2.5 | 3.5 | 5.5 | Escaleno   |
