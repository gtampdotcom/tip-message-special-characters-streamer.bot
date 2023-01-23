# tip-message-special-characters-streamer.bot

C# script for https://streamer.bot that decodes special html characters that don't normally display correctly.

![alt text](https://github.com/gtampdotcom/tip-message-special-characters-streamer.bot/blob/main/special%20characters%20broken.png?raw=true)

&#39 is changed to '

&amp is changed to &

&lt is changed to <

&gt is changed to >

![alt text](https://github.com/gtampdotcom/tip-message-special-characters-streamer.bot/blob/main/special%20characters%20fixed.png?raw=true)

I wrote it for displaying StreamElements tip messages in chat. You can just do that using the StreamElements bot but I wanted to use Streamer.bot.

Copy the big line of text below, run Streamer.bot, click on the Import tab and paste the text into the Import String textbox.

TlM0RR+LCAAAAAAABACtVdtu4kgQfV9p/wGhzds4al8geN7ACY4d4kkg4Ms6D+3uxhjal/Ulxozm37fbDBMuyWpXWiSE+1TVqapTpvr77791Ot03khdRmnS/dqQvLZDAmLBTt7s/QlQyc8GQP/m50/m+/2GmCHO/vtxfgqW8FAjoI0ERVSSouCcLWAIyVMQBEAe9PVcb9FdFKs6fVJS+oySBASWcr8wrcoRvEa0wGedpfB8VZZo3zGUJaXHkcyi4jLKjPGGeVhmHyRtJyuLIAmkNm2JaJZdUOUxwGg/bli+tKE1QleeM7tJ2IdOJVK1LSbY8sHvFCp0XJOd1X3XYISO48wdHh3FaJeVVhz9rbSbUXHX8NuKRFAUMyZXffW+lpc1ysiTMFw8R4uEsBTj1+DmnwRL1MIQCUokiKH0oCgOprwgg6GFVGsjKYEnOqGsShauW8PqMsmwyrrl4Bh9EPxnuPw14X1+CyZazvaM/vnym4unr+QvGpEB5lP0c3Ll1Q0g2pNEbuRjcfuxcQSY2OZtfa9S++r7NSkzrwvcfI5SnRbosr627F98f56yaOs03fcX335RrcC0DWVR9Py5QmtMouMaUdo8JX08zB01JtBS3HU2aQeja2yKQUYjkEXUlugq00Rrq48a1LeA55s7QaWXcTzOkjUrPsXaujSmqwQOPhfdTgO4f+5NGTaAzTbFtVK6klhMJA9cWa09XQXuWebz4K37iWLVnW5lr16UrrVYoHq+xvmhQI+7wvUlZLEVRLwrkZ0sLwQN2rCyIUTiX6Y75ld/qS2yyoU8c1543lpaMRDfeZm4zWgf6eIea0e38bmUGDAviObMXjJfW2DYLaD+Gbqy+sb7HRF+ssTOlD9qG229un1NTc7wVikYxdFbUG7M+7lhtsrXypHn4NBux2vHObkwAnZF16M+goFro6gvrhdeYPrzwfBvTi6ni2dP5ie8tCD/CJ9SkSN+uXGmeGpG7ftxtboxoWBiakRjRZl+b7WWs5s1Cp/WLvdghaZx4s6Fq6B/hvZnnjAo2V9afEfP5fGuMcKINIzMysr129LM+P8Krebyomb5rbxZGZrwFB74n7f/gwy2fodWhsVaig4Zt33Preab1XjxnOmL6i4G9qLAWRvikX6P4SNcDD4oXADsmf7cbbM9bPZfP4IF/L/cdSuMsop/8mTGhsJmVML/c0vtt025DAAhAYi8QwAD2BCW4AQL7SgIZAAgVCd9ISvBft6HKPx8vxPOF9G/WIThah4fH1/MbR+cJ2rX1enxRUQqzguAj697YEu099zfxUSgLi2N2AR78f/wNt8hObSEIAAA=

It will import an events action named tip. By default it displays as %tipUsername% tipped $%tipAmount% %tipCurrency% "%tipMessage%". Edit the sub action, "Twitch Message" to change it.

For the action to trigger, you need to click on Integrations > StreamElements > Events > Tip > generic and select our newly imported tip action.

![streamer bot streamelements](https://user-images.githubusercontent.com/910729/213984552-90e65aae-2f0d-4ddd-841b-3fe10c4956e1.jpg)
