#version 330 core
out vec4 FragColor;
in vec3 ourColor;
uniform vec4 ourColor1;
void main()
{
    FragColor = vec4(ourColor.x+ourColor1.x,ourColor.y+ourColor1.y,ourColor.z+ourColor1.z,1.0);
}