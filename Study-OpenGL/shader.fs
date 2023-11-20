#version 330 core
out vec4 FragColor;
in vec3 ourColor;
uniform vec4 ourColor1;
void main()
{
    FragColor = ourColor1+vec4(ourColor,1.0);
}