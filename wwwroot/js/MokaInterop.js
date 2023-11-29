export async function setLocalStorage(key, value) {
    await localStorage.setItem(key, value);
}

export function getLocalStorage(key) {
    return localStorage.getItem(key);
}

export async function updateColors() {
    const isDark = localStorage.getItem("mode");
    if (isDark == null) return;
    await ui("mode", isDark);
    const theme = localStorage.getItem("theme");
    if (theme == null) return;
    await ui("theme", theme);
}

export async function setMode(mode) {
    await ui("mode", mode);
    await localStorage.setItem("mode", mode);
}

export async function setTheme(theme) {
    await ui("theme", theme);
    await localStorage.setItem("theme", theme);
}