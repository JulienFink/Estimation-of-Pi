" MONTE CARLO METHOD - ESTIMATE PI VALUE WITH THE UNIFORM FUNCTION [0;1] "

X = runif(10000, -1, 1);
Y = runif(10000, -1, 1);

t = seq(0, 2*pi, length.out = 1000);
plot(cos(t), sin(t), type = "l");
points(X,Y);

give_color = ifelse( (X^2 + Y^2)<1, "red", "blue");
points(X,Y, col = give_color);

print( mean(X^2 + Y^2 < 1) );
print(pi);
"Les 2 valeurs sont proches ^^"

print('Estimate value of pi :');
4*mean(X^2 + Y^2 < 1)