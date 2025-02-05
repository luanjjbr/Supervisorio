close all;
clear;
clc;

X = 0;Y = 0;Z= 0;% Posição final desejada

% Parâmetros DH do robô
a1 = 0; a2 = 92; a3 = 92;  % Distâncias entre as juntas
d1 = 0; d2 = 0; d3 = 0;     % Deslocamentos ao longo de Z (exemplo)

% Definindo os parâmetros DH para o robô 3R
% A sintaxe é: link([αi ai θi di tipo])
% Onde:
% αi: Ângulo de Link
% Representa o ângulo entre os eixos Z das juntas i e i+1, medido ao longo do eixo X. 
% Ele define a rotação do sistema de coordenadas da junta i para a junta i+1.
%
% ai: Deslocamento ao Longo do Eixo X
% Representa a distância entre os eixos Z das juntas i e i+1, medida ao longo do eixo X. 
% Ele define o deslocamento entre as duas juntas na direção do eixo X.
%
% θi: Ângulo de Rotação
% Representa o ângulo de rotação da junta i ao redor do eixo Z. 
% Este parâmetro controla a rotação efetiva da junta em torno de seu eixo, no caso de uma junta rotacional.
%
% di: Deslocamento ao Longo do Eixo Z
% Representa o deslocamento ao longo do eixo Z da junta i. 
% Para juntas lineares, esse valor é variável e define a distância ao longo do eixo Z.
% Definindo os parâmetros DH do robô 3R (αi ai θi di tipo)

% A sintaxe é: link([αi ai θi di tipo])
L1 = link([-pi/2 a1 0 d1 0]);   % Junta 1: α1=-π/2, a1=0, θ1=0, d1=0
L2 = link([0 a2 0 d2 0]);      % Junta 2: α2=0, a2=92, θ2=0, d2=0
L3 = link([0 a3 0 d3 0]);      % Junta 3: α3=0, a3=92, θ3=0, d3=0

% Criando o robô 3R
r = robot({L1, L2, L3}, '3R');

% Matriz de transformação desejada
T = transl(X, Y, Z) % Define posição desejada (X, Y, Z)

% Calculando a cinemática inversa
q = ikine(r, T)
figure
plot(r, q);
drivebot(r);

%=========================================================================================

% Cálculo de θ1
theta1 = atan2(Y, X);

% Calcular a distância do ponto final em relação à base
r1 = sqrt(X^2 + Y^2);  % Distância no plano XY

% Calcular a distância no plano XY e Z
P = sqrt(r1^2 + (Z - d1)^2);  % Distância ao longo de Z

% Cálculo do ângulo θ2 usando a lei dos cossenos
cos_theta2 = (P^2 - a2^2 - a3^2) / (2 * a2 * a3);
theta2 = acos(cos_theta2);

% Cálculo do ângulo θ3
theta3 = atan2(Z - d1, r1) - acos((a2^2 + P^2 - a3^2) / (2 * a2 * P));

% Exibir os ângulos calculados
disp(['θ1 = ', num2str(theta1)]);
disp(['θ2 = ', num2str(theta2)]);
disp(['θ3 = ', num2str(theta3)]);

% Plotando o robô na configuração calculada
% figure;
% plot(r,[theta1 theta3 theta2]);
% drivebot(r);