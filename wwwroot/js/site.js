let revealObserver;
let countObserver;
let scrollScheduled = false;
let isInitialized = false;

const reducedMotion = () => window.matchMedia('(prefers-reduced-motion: reduce)').matches;

function observeReveals() {
    if (!revealObserver) {
        revealObserver = new IntersectionObserver((entries, observer) => {
            entries.forEach(entry => {
                if (!entry.isIntersecting) return;
                entry.target.classList.add('is-visible');
                observer.unobserve(entry.target);
            });
        }, { threshold: 0.11, rootMargin: '0px 0px -5% 0px' });
    }

    document.querySelectorAll('[data-reveal]:not(.is-visible)').forEach(element => {
        revealObserver.observe(element);
    });
}

function animateCount(element) {
    const target = Number(element.dataset.count || 0);
    const suffix = element.dataset.suffix || '';

    if (reducedMotion()) {
        element.textContent = `${target}${suffix}`;
        return;
    }

    const duration = 1450;
    const start = performance.now();

    const tick = now => {
        const progress = Math.min((now - start) / duration, 1);
        const eased = 1 - Math.pow(1 - progress, 4);
        element.textContent = `${Math.round(target * eased)}${suffix}`;

        if (progress < 1) requestAnimationFrame(tick);
    };

    requestAnimationFrame(tick);
}

function observeCounters() {
    countObserver = new IntersectionObserver((entries, observer) => {
        entries.forEach(entry => {
            if (!entry.isIntersecting) return;
            animateCount(entry.target);
            observer.unobserve(entry.target);
        });
    }, { threshold: 0.55 });

    document.querySelectorAll('[data-count]').forEach(element => countObserver.observe(element));
}

function updateScrollState() {
    scrollScheduled = false;
    const scrollTop = window.scrollY || document.documentElement.scrollTop;
    const documentHeight = document.documentElement.scrollHeight - window.innerHeight;
    const progress = documentHeight > 0 ? Math.min(scrollTop / documentHeight, 1) : 0;
    const header = document.getElementById('site-header');
    const progressBar = document.getElementById('scroll-progress');

    header?.classList.toggle('is-scrolled', scrollTop > 38);
    if (progressBar) progressBar.style.width = `${progress * 100}%`;

    if (!reducedMotion()) {
        document.querySelectorAll('[data-parallax]').forEach(element => {
            const speed = Number(element.dataset.parallax || 0);
            const rect = element.parentElement?.getBoundingClientRect();
            if (!rect || rect.bottom < -200 || rect.top > window.innerHeight + 200) return;
            const centerOffset = rect.top + rect.height / 2 - window.innerHeight / 2;
            element.style.transform = `translate3d(0, ${centerOffset * speed}px, 0)`;
        });
    }
}

function onScroll() {
    if (scrollScheduled) return;
    scrollScheduled = true;
    requestAnimationFrame(updateScrollState);
}

export function init() {
    if (isInitialized) return;
    isInitialized = true;
    observeReveals();
    observeCounters();
    window.addEventListener('scroll', onScroll, { passive: true });
    window.addEventListener('resize', onScroll, { passive: true });
    updateScrollState();
}

export function refreshReveals() {
    requestAnimationFrame(observeReveals);
}

export function setBodyLock(locked) {
    document.body.classList.toggle('is-locked', locked);
}

export function destroy() {
    revealObserver?.disconnect();
    countObserver?.disconnect();
    window.removeEventListener('scroll', onScroll);
    window.removeEventListener('resize', onScroll);
    document.body.classList.remove('is-locked');
    isInitialized = false;
}
