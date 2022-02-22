const tabList = document.querySelector('[role="tablist"]');
const tabs = tabList.querySelectorAll('[role="tab"]');



//tabList.addEventListener('keydown', changeTabFocus);

//tabs.forEach((tab) => {
//    tab.addEventListener('click', changeTabPanel);
//});


let tabFocus = 0;

function changeTabFocus(e) {
    console.log("Change tab focus");
    const keydownLeft = 37;
    const keydownRight = 39;

    // change the tabindex of the current tab to -1
    if (e.keyCode == keydownLeft || (e.keyCode == keydownRight)) {

        tabs[tabFocus].setAttribute("tabindex", -1);
        // if the right key is pushed, move to the next tab of the right

        if (e.keyCode === keydownRight) {
            tabFocus++;
            if (tabFocus >= tabs.length) {
                tabFocus = 0;
            }
            console.log(tabFocus);
        } else if (e.keyCode === keydownLeft) {
            tabFocus--;
            if (tabFocus < 0) {
                tabFocus = tabs.length - 1;
            }
        }

        tabs[tabFocus].setAttribute("tabindex", 0);
        tabs[tabFocus].focus();

    }



}

function changeTabPanel(e) {
    console.log("Change Tab Panel");
    const targetTab = e.target;
    const targetPanel = targetTab.getAttribute("aria-controls");
    const targetImage = targetTab.getAttribute("data-image");

    const tabContainer = targetTab.parentNode;
    const mainContainer = tabContainer.parentNode;

    tabContainer.querySelector('[aria-selected="true"]').setAttribute('aria-selected', false);
    targetTab.setAttribute('aria-selected', true);

    hideContent(mainContainer, '[role="tabpanel"]');
    hideContent(mainContainer, ".images");
    //hideImage(mainContainer, "img");

    showContent(mainContainer, [`#${targetPanel}`]);
    showContent(mainContainer, [`#${targetImage}`]);
    //showImage(mainContainer,[`#${targetImage}`]);

}

function hideContent(parent, content) {

    parent
        .querySelectorAll(content)
        .forEach((item) => item.setAttribute("hidden", true));

}

function hideImage(parent, content) {

    parent
        .querySelectorAll(content)
        .forEach((item) => item.classList.add("hidden"));

}
function showContent(parent, content) {

    parent.querySelector(content).removeAttribute('hidden');

}

function showImage(parent, content) {
    parent.querySelector(content).classList.remove('hidden');
}