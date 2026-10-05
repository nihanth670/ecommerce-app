import React, { useEffect, useState, useMemo } from 'react';

function ProductList() {
  const [products, setProducts] = useState([]);
  const [selectedCategory, setSelectedCategory] = useState('All');
  const [cart, setCart] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  // Fetch products from .NET backend
  useEffect(() => {
    // Vite-compatible environment variable
    const apiUrl = import.meta.env.VITE_API_URL || 'http://localhost:5000';
    
    fetch(`${apiUrl}/api/products`)
      .then(res => {
        if (!res.ok) throw new Error('Failed to fetch products');
        return res.json();
      })
      .then(data => {
        setProducts(data);
        setLoading(false);
      })
      .catch(err => {
        console.error(err);
        setError(err.message);
        setLoading(false);
      });
  }, []);

  // Dynamically extract unique categories
  const categories = useMemo(() => {
    return ['All', ...new Set(products.map(p => p.category))];
  }, [products]);

  // Filter products based on active category
  const filteredProducts = useMemo(() => {
    return selectedCategory === 'All'
      ? products
      : products.filter(p => p.category === selectedCategory);
  }, [products, selectedCategory]);

  // Add item to cart
  const addToCart = (product) => {
    setCart(prevCart => {
      const existing = prevCart.find(item => item.id === product.id);
      if (existing) {
        return prevCart.map(item =>
          item.id === product.id ? { ...item, quantity: item.quantity + 1 } : item
        );
      }
      return [...prevCart, { ...product, quantity: 1 }];
    });
  };

  // Remove item from cart
  const removeFromCart = (productId) => {
    setCart(prevCart => prevCart.filter(item => item.id !== productId));
  };

  // Calculate cart total amount
  const totalPrice = cart.reduce((total, item) => total + item.price * item.quantity, 0);

  if (loading) return <div style={{ padding: '20px' }}>Loading products...</div>;
  if (error) return <div style={{ padding: '20px', color: 'red' }}>Error: {error}</div>;

  return (
    <div style={{ padding: '20px' }}>
      <h1>E-commerce Store</h1>

      {/* Category Buttons */}
      <div style={{ marginBottom: '20px' }}>
        {categories.map(cat => (
          <button
            key={cat}
            onClick={() => setSelectedCategory(cat)}
            style={{
              marginRight: '10px',
              padding: '8px 12px',
              background: selectedCategory === cat ? '#1976d2' : '#e0e0e0',
              color: selectedCategory === cat ? '#fff' : '#000',
              border: 'none',
              borderRadius: '4px',
              cursor: 'pointer'
            }}
          >
            {cat}
          </button>
        ))}
      </div>

      {/* Product Grid */}
      <div
        style={{
          display: 'grid',
          gridTemplateColumns: 'repeat(auto-fill, minmax(200px, 1fr))',
          gap: '20px'
        }}
      >
        {filteredProducts.map(p => (
          <div
            key={p.id}
            style={{
              border: '1px solid #ccc',
              borderRadius: '8px',
              padding: '10px',
              textAlign: 'center'
            }}
          >
            <img
              src={p.imageUrl}
              alt={p.name}
              style={{ width: '100%', height: '150px', objectFit: 'cover' }}
            />
            <h3>{p.name}</h3>
            <p>₹{p.price}</p>
            <p style={{ fontStyle: 'italic', color: '#555' }}>{p.category}</p>
            <button
              onClick={() => addToCart(p)}
              style={{
                marginTop: '10px',
                padding: '8px 12px',
                background: '#1976d2',
                color: '#fff',
                border: 'none',
                borderRadius: '4px',
                cursor: 'pointer'
              }}
            >
              Add to Cart
            </button>
          </div>
        ))}
      </div>

      {/* Cart Summary */}
      <div style={{ marginTop: '40px', padding: '20px', borderTop: '2px solid #ccc' }}>
        <h2>Cart Summary</h2>
        {cart.length === 0 ? (
          <p>Your cart is empty.</p>
        ) : (
          <div>
            {cart.map(item => (
              <div
                key={item.id}
                style={{
                  display: 'flex',
                  justifyContent: 'space-between',
                  alignItems: 'center',
                  marginBottom: '10px'
                }}
              >
                <span>
                  {item.name} (x{item.quantity}) - ₹{item.price * item.quantity}
                </span>
                <button
                  onClick={() => removeFromCart(item.id)}
                  style={{
                    background: '#d32f2f',
                    color: '#fff',
                    border: 'none',
                    padding: '4px 8px',
                    borderRadius: '4px',
                    cursor: 'pointer'
                  }}
                >
                  Remove
                </button>
              </div>
            ))}
            <hr />
            <h3>Total Amount: ₹{totalPrice}</h3>
          </div>
        )}
      </div>
    </div>
  );
}

export default ProductList;