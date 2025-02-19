close all;
clear;
clc;
X = 50;Y = 50;Z= 50;% Posição final desejada
% Parâmetros DH do robô
a1 = 0; a2 = 92; a3 = 92;  % Distâncias entre as juntas
d1 = 0; d2 = 0; d3 = 0;     % Deslocamentos ao longo de Z (exemplo)
% A sintaxe é: link([αi ai θi di tipo])
L1 = link([-pi/2 a1 0 d1 0]);   % Junta 1: α1=-π/2, a1=0, θ1=0, d1=0
L2 = link([0 a2 0 d2 0]);      % Junta 2: α2=0, a2=92, θ2=0, d2=0
L3 = link([0 a3 0 d3 0]);      % Junta 3: α3=0, a3=92, θ3=0, d3=0
% Criando o robô
r = robot({L1, L2, L3}, '3R');

% === Cálculo dos Ângulos Manuais ===
Z = -Z;
theta1 = atan2(Y, X);
r1 = sqrt(X^2 + Y^2);
P = sqrt(r1^2 + (Z - d1)^2);

G = (P^2 - a2^2 - a3^2) / (2 * a2 * a3);
theta3 = acos(G);

theta2 = atan2(Z - d1, r1) - acos((a2^2 + P^2 - a3^2) / (2 * a2 * P));

% Exibir ângulos calculados
disp(['θ1 = ', num2str(theta1)]);
disp(['θ2 = ', num2str(theta2)]);
disp(['θ3 = ', num2str(theta3)]);

% === Segunda Figura ===
figure(2); % Criar a segunda figura
plot(r, [theta1 theta2 theta3]); % Plotar nova configuração
view(45, 30); % Define visão isométrica novamente
title('Posição Calculada do Robô com Fórmula dos Ângulos Manuais');
grid on;
hold on;
drivebot(r);
