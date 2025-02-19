close all;
clear;
clc;
% Parâmetros DH do robô
a1 = 0; a2 = 92; a3 = 92;  % Distâncias entre as juntas
d1 = 0; d2 = 0; d3 = 0;     % Deslocamentos ao longo de Z (exemplo)
% A sintaxe é: link([αi ai θi di tipo])
L1 = link([-pi/2 a1 0 d1 0]);   % Junta 1: α1=-π/2, a1=0, θ1=0, d1=0
L2 = link([0 a2 0 d2 0]);      % Junta 2: α2=0, a2=92, θ2=0, d2=0
L3 = link([0 a3 0 d3 0]);      % Junta 3: α3=0, a3=92, θ3=0, d3=0
% Criando o robô
r = robot({L1, L2, L3}, '3R');
% === Primeira Figura ===
figure(1); % Criar a primeira figura
plot(r, [0 0 0]); % Plotar o robô na primeira configuração
view(45, 30); % Define uma visão isométrica
title('Posição Inicial do Robô (todos os ângulos em 0)');
grid on;
hold on;
drivebot(r);
